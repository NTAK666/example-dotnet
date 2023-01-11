import { FC, useContext, useState } from "react";
import { CartContext, ICartContext } from "../contexts/cart.context";
import { Link, useNavigate } from "react-router-dom";
import { AiOutlineClose } from "react-icons/ai";
import { useMutation } from "@tanstack/react-query";
import { createOrder, CreateOrderItem } from "../services/order/order.services";

type CartPageProps = {}

const CartPage: FC<CartPageProps> = ( {} ) => {
	const { cart, updateCart, removeItem, updateQuantity, clearCart } = useContext(CartContext) as ICartContext;

	const { mutateAsync } = useMutation(['CREATE_ORDER'], createOrder);

	const navigate = useNavigate()

	const [customerPayload, setCustomerPayload] = useState({
		streetAddress: "",
		city: "",
		phoneNumber: "",
		email: ""
	});

	const handleOrder = () => {
		mutateAsync({
			orderDetails: cart!.carts.map(item => {
				return {
					productId: item.product.id,
					quantity: item.quantity
				} as CreateOrderItem
			}),
		}).then(res => {
			clearCart();
			navigate("/profile/orders")
		}).catch(err => {
			console.log(err)
		})
	}

	return (
		<div className='container grid grid-cols-12 items-start pb-16 pt-4 gap-6'>

			<div className='col-span-6 border border-gray-200 p-4 rounded'>
				<h3 className='text-lg font-medium capitalize mb-4'>Checkout</h3>
				<div className='space-y-4'>
					<div className='grid grid-cols-2 gap-4'>
						<label htmlFor='address' className='text-gray-600'>Street address</label>
						<input
							value={ customerPayload.streetAddress } onChange={ ( e ) => {
							setCustomerPayload({ ...customerPayload, streetAddress: e.target.value })
						} } type='text' name='address' id='address' className='rounded'/>
					</div>
					<div className='grid grid-cols-2 gap-4'>
						<label htmlFor='city' className='text-gray-600'>City</label>
						<input
							value={ customerPayload.city } onChange={ ( e ) => {
							setCustomerPayload({ ...customerPayload, city: e.target.value })
						} } type='text' name='city' id='city' className='rounded'/>
					</div>
					<div className='grid grid-cols-2 gap-4'>
						<label htmlFor='phone' className='text-gray-600'>Phone number</label>
						<input
							value={ customerPayload.phoneNumber } onChange={ ( e ) => {
							setCustomerPayload({ ...customerPayload, phoneNumber: e.target.value })
						} } type='text' name='phone' id='phone' className='rounded'/>
					</div>
					<div className='grid grid-cols-2 gap-4'>
						<label htmlFor='email' className='text-gray-600'>Email address</label>
						<input
							value={ customerPayload.email } onChange={ ( e ) => {
							setCustomerPayload({ ...customerPayload, email: e.target.value })
						} } type='email' name='email' id='email' className='rounded'/>
					</div>
				</div>

			</div>

			<div className='col-span-6 border border-gray-200 p-4 rounded min-h-[295px]'>
				<h4 className='text-gray-800 text-lg mb-4 font-medium uppercase'>order summary</h4>
				<div className='space-y-2'>
					{
						cart?.carts.map(( item, index ) => {
							return <div className='flex justify-between items-center cursor-pointer'>
								<span onClick={ () => removeItem(item) } className='w-[20px]'>
									<AiOutlineClose color='red'/>
								</span>
								<Link
									to={ `/product/${ item.product.id }` } className='text-gray-800 font-medium flex-grow line-clamp-1'>
									<h5>{ item.product.name }</h5>
								</Link>
								<input
									value={ item.quantity } className='w-2/6 justify-self-end' type='number'
									onChange={ ( e ) => updateQuantity(
										item,
										parseInt(e.target.value)
									) }/>
								<p className='text-gray-800 font-medium w-1/6 justify-self-end text-right'>{
									`$${ parseInt(item.product.price) * item.quantity }`
								}</p>
							</div>
						})
					}
				</div>

				<div className='flex justify-between text-gray-800 font-medium py-3 uppercas'>
					<p className='font-semibold'>Total</p>
					<p>
						{
							`$${ cart?.carts.reduce(( acc, item ) => {
								return acc + (parseInt(item.product.price) * item.quantity);
							}, 0) }`
						}
					</p>
				</div>

				<div className='flex items-center mb-4 mt-2'>
					<input
						type='checkbox' name='aggrement' id='aggrement'
						className='text-primary focus:ring-0 rounded-sm cursor-pointer w-3 h-3' required/>
					<label htmlFor='aggrement' className='text-gray-600 ml-3 cursor-pointer text-sm'>I agree to the <a
						href='#'
						className='text-primary'>terms & conditions</a></label>
				</div>

				<button
					onClick={ () => handleOrder() }
					className='block w-full py-3 px-4 text-center text-white bg-primary border border-primary rounded-md hover:bg-transparent hover:text-primary transition font-medium'>
					Place Order
				</button>
			</div>

		</div>
	)
}

export default CartPage;
