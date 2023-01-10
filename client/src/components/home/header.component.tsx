import { FC, useContext } from "react";
import { AiOutlineSearch } from "react-icons/ai";
import { Link } from "react-router-dom";
import { AuthContext, IAuthContext } from "../../contexts/auth.context";
import { CartContext, ICartContext } from "../../contexts/cart.context";

type HeaderComponentProps = {}

const HeaderComponent: FC<HeaderComponentProps> = ( {} ) => {
	const { isAuth } = useContext(AuthContext) as IAuthContext;
	const { cart } = useContext(CartContext) as ICartContext;
	return (
		<header className='py-4 shadow-sm bg-white'>
			<div className='container flex items-center justify-between'>
				<Link to='/'>
					<span className='text-[#0A2647] text-2xl font-semibold'>E</span>
					<span className='text-[#FF6E31] font-semibold text-2xl'>Commerce</span>
				</Link>
				<div className='w-full max-w-xl relative flex'>
                <span
	                className='absolute top-1/2 left-4 transform -translate-y-1/2 text-lg text-gray-400'>
                    <AiOutlineSearch size={ 24 }/>
                </span>
					<input
						type='text' name='search' id='search'
						className='w-full border border-primary border-r-0 pl-12 py-3 pr-3 rounded-l-md focus:outline-none'
						placeholder='Search'/>
					<button
						className='bg-primary border border-primary text-white px-8 rounded-r-md hover:bg-transparent hover:text-primary transition'>Search
					</button>
				</div>

				<div className='flex items-center space-x-4'>
					<div className='text-center text-gray-700 hover:text-primary transition relative'>
						<div className='text-2xl'>
							<i className='fa-solid fa-bag-shopping'></i>
						</div>
						{
							isAuth && (
								<Link to='/profile/cart' className='text-md leading-3'>
									Cart { `( ${ cart?.carts.reduce(( acc, cur ) => acc + cur.quantity, 0) } )` }
								</Link>
							)
						}
					</div>
				</div>
			</div>
		</header>
	)
}

export default HeaderComponent;
