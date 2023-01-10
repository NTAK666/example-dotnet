import { FC, useContext } from "react";
import { Link } from "react-router-dom";
import { AuthContext, IAuthContext } from "../../contexts/auth.context";

type NavComponentProps = {}

const NavComponent: FC<NavComponentProps> = ( {} ) => {
	const { isAuth, user, logout } = useContext(AuthContext) as IAuthContext;
	return (
		<nav className='bg-gray-800'>
			<div className='container flex'>
				<div className='px-8 py-4 bg-primary flex items-center cursor-pointer relative group'>
					<span className='capitalize  text-white z-[99999] relative'>All Categories</span>
				</div>

				<div className='flex items-center justify-between flex-grow pl-12'>
					<div className='flex items-center space-x-6 capitalize'>
						<Link to='/' className='text-gray-200 hover:text-white transition'>
							Home
						</Link>
						<Link to='/categories' className='text-gray-200 hover:text-white transition'>
							Shop
						</Link>
						<Link to='about-us' className='text-gray-200 hover:text-white transition'>
							About us
						</Link>
						<Link to='contact-us' className='text-gray-200 hover:text-white transition'>
							Contact us
						</Link>
					</div>
					{
						isAuth ? <div className='flex gap-5'>
							<Link to='/profile' className='text-white font-semibold'>
								Hello : { user?.userName }
							</Link>
							<span
								className='text-white font-semibold cursor-pointer'
								onClick={ () => logout() }
							>
								Logout
							</span>
						</div> : <>
							<Link to='/auth/login' className='text-gray-200 hover:text-white transition'>
								Login
							</Link>
						</>
					}
				</div>
			</div>
		</nav>

	)
}

export default NavComponent;
