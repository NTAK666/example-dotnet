import { FC, useContext } from "react";
import { Product } from "../../services/product/product.services";
import { AiFillStar } from 'react-icons/ai'
import { Link } from "react-router-dom";
import { CartContext, ICartContext } from "../../contexts/cart.context";

type NewArrivalComponentProps = {
	products?: Product[]
}

const NewArrivalComponent: FC<NewArrivalComponentProps> = ( { products } ) => {
	const { cart, updateCart } = useContext(CartContext) as ICartContext;

	const handleAddToCart = ( product: Product ) => {
		updateCart({
			product,
			quantity: 1
		})
	}

	return (
		<div className='container pb-16'>
			<h2 className='text-2xl font-medium text-gray-800 uppercase mb-6'>top new arrival</h2>
			<div className='grid grid-cols-4 gap-6'>
				{ products?.slice(0, 4).map(( product, idx ) => {
					return <div className='bg-white shadow  overflow-hidden group' key={ idx }>
						<div className='relative'>
							<img src={ `${ product.image }` } alt='product 1' className='w-full rounded-tr-xl rounded-tl-xl'/>
						</div>
						<div className='pt-4 pb-3 px-4'>
							<Link to={ `/product/${ product.id }` }>
								<h4
									className='uppercase font-medium text-xl mb-2 text-gray-800 hover:text-primary transition'>Guyer Chair
								</h4>
							</Link>
							<div className='flex items-baseline mb-1 space-x-2'>
								<p className='text-xl text-primary font-semibold'>{ `$${ product.price }` }</p>
							</div>
							<div className='flex items-center'>
								<div className='flex gap-1 text-sm text-yellow-400'>
									<span>
										<AiFillStar/>
									</span>
									<span>
										<AiFillStar/>
									</span>
									<span>
										<AiFillStar/>
									</span>
									<span>
										<AiFillStar/>
									</span>
									<span>
										<AiFillStar/>
									</span>
								</div>
								<div className='text-xs text-gray-500 ml-3'>(150)</div>
							</div>
						</div>
						<button
							onClick={ () => handleAddToCart(product) }
							className='block w-full py-1 text-center text-white bg-primary border border-primary rounded-b hover:bg-transparent hover:text-primary transition'>
							Add to Cart
						</button>
					</div>
				}) }
			</div>
		</div>
	)
}

export default NewArrivalComponent;
