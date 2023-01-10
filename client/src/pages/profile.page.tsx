import { FC, useContext, useEffect, useState } from "react";
import { AuthContext, IAuthContext } from "../contexts/auth.context";
import { Link, useLocation } from "react-router-dom";
import { useQuery } from "@tanstack/react-query";
import { getOrders, OrderResponse } from "../services/order/order";

type ProfilePageProps = {}

const ProfilePage: FC<ProfilePageProps> = ( {} ) => {

	const { pathname } = useLocation();

	const [showProfile, setShowProfile] = useState<boolean>(false);

	const { user } = useContext(AuthContext) as IAuthContext;

	const { data: orderDetails, refetch } = useQuery(['GET_ORDERS'], getOrders)

	useEffect(() => {
		if (pathname === '/profile') {
			setShowProfile(true);
		} else {
			setShowProfile(false);
		}
	}, [pathname])


	// @ts-ignore
	return (
		<div className='container grid grid-cols-12 items-start gap-6 pt-4 pb-16'>

			<div className='col-span-3'>
				<Link to='/profile'>
					<div className='px-4 py-3 shadow flex items-center gap-4'>
						<div className='flex-shrink-0'>
							<img
								src='https://picsum.photos/300/300' alt='profile'
								className='rounded-full w-14 h-14 border border-gray-200 p-1 object-cover'/>
						</div>
						<div className='flex-grow'>
							<p className='text-gray-600'>Hello,</p>
							<h4 className='text-gray-800 font-medium'>{ user?.userName }</h4>
						</div>
					</div>
				</Link>

				<div className='mt-6 bg-white shadow rounded p-4 divide-y divide-gray-200 space-y-4 text-gray-600'>
					<div className='space-y-1 pl-8'>
						<Link to='/profile/orders' className='relative hover:text-primary block font-medium capitalize transition'>
							View all orders
						</Link>
					</div>
				</div>
			</div>

			<div className='col-span-9 grid grid-cols-2 gap-4'>

				{
					showProfile && (
						<div className='shadow rounded bg-white px-4 pt-6 pb-8'>
							<div className='flex items-center justify-between mb-4'>
								<h3 className='font-medium text-gray-800 text-lg'>Personal Profile</h3>
							</div>
							<div className='space-y-1'>
								<h4 className='text-gray-700 font-medium'>{ user?.userName }</h4>
								<p className='text-gray-800'>{ user?.email }</p>
								<p className='text-gray-800'>{ user?.bio ?? "Ecommerce Shop" }</p>
							</div>
						</div>
					)
				}

				{
					!showProfile && (
						// @ts-ignore
						orderDetails?.data.map(( item: OrderResponse ) => {
							return <div key={ Math.random() } className='shadow rounded bg-white px-4 pt-6 pb-8'>
								<div className='flex items-center justify-between mb-4'>
									<h3 className='font-medium text-gray-800 text-lg'>Order Details</h3>
								</div>
								<div className='space-y-1'>
									<h4>Total : {
										item?.orderDetails.reduce(( acc, item ) => {
											return acc + (parseInt(item.product.price) * item.quantity);
										}, 0)
									}$
									</h4>
									<h4 className='text-gray-700 '>{ item.status == 0 ? "Pending" : "Payed" }</h4>
									<ul className='space-y-2'>
										{
											item.orderDetails.map(( item, index ) => {
												return <Link to={ `/product/${ item.product.id }` }>
													<li>{ item.product.name }</li>
												</Link>
											})
										}
									</ul>
								</div>
							</div>
						})
					)
				}

			</div>

		</div>
	)
}

export default ProfilePage;
