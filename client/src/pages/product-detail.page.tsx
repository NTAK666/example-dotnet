import { FC, useContext, useEffect, useState } from "react";
import { useQuery } from "@tanstack/react-query";
import { getProductById, getProductsByCategory, Product } from "../services/product/product.services";
import { Link, useNavigate, useParams } from "react-router-dom";
import LoadingComponent from "../components/loading.component";
import "swiper/css";
import "swiper/css/navigation";
import { Swiper, SwiperSlide } from 'swiper/react';
import { Pagination } from "swiper";
import { AiFillStar } from "react-icons/ai";
import { CartContext, ICartContext } from "../contexts/cart.context";

type ProductDetailPageProps = {}

const ProductDetailPage: FC<ProductDetailPageProps> = () => {
	const { cart, updateCart } = useContext(CartContext) as ICartContext;
	const [quantityValue, setQuantityValue] = useState<number>(1);

	const { productId } = useParams()
	const [getBack, setGetBack] = useState(false)
	const [categoryId, setCategoryId] = useState<string | undefined>(undefined)
	const navigate = useNavigate()

	const { data: product, refetch } = useQuery(['GET_PRODUCT_BY_ID', productId], () => getProductById(productId), {
		enabled: false
	})

	const {
		data: productRelated,
		refetch: refetchRelated
	} = useQuery(['GET_PRODUCT_RELATED', productId], () => getProductsByCategory(categoryId!, 0), {
		enabled: false
	});

	useEffect(() => {
		if (productId === undefined) {
			setGetBack(true)
		} else {
			setGetBack(false)
			refetch().then(async res => {
				if (res.data === undefined) {
					navigate("/");
				}
				setCategoryId(res.data?.category?.id)
				await refetchRelated();
			})
		}
	}, [productId, refetch, product, navigate])

	const handleAddToCart = ( product: Product ) => {
		if (quantityValue <= 0) return;
		updateCart({
			product,
			quantity: quantityValue,
		});
	}

	return (
		<body>

		{
			product === undefined ? (
				<div className='h-[1000px]'>
					<LoadingComponent/>
				</div>
			) : (
				<>
					<div className='container grid grid-cols-2 gap-6 mt-10'>
						<div className='flex items-center'>
							<Swiper
								pagination={ {
									dynamicBullets: true,
								} }
								modules={ [Pagination] } className='mySwiper'
							>
								{
									product.gallary.map(( item, index ) => {
										return <SwiperSlide>
											<img src={ item } alt=''/>
										</SwiperSlide>
									})
								}
							</Swiper>
						</div>

						<div>
							<h2 className='text-3xl font-medium uppercase mb-2'>{ product.name }</h2>
							<div className='flex items-center mb-4'>
								<div className='flex gap-1 text-sm text-yellow-400'>
									<AiFillStar/>
									<AiFillStar/>
									<AiFillStar/>
									<AiFillStar/>
									<AiFillStar/>
								</div>
								<div className='text-xs text-gray-500 ml-3'>(150 Reviews)</div>
							</div>
							<div className='space-y-2'>
								<p className='text-gray-800 font-semibold space-x-2'>
									<span>Availability: </span>
									<span className='text-green-600'>In Stock</span>
								</p>
								<p className='space-x-2'>
									<span className='text-gray-800 font-semibold'>Brand: </span>
									<span className='text-gray-600'>Apex</span>
								</p>
								<p className='space-x-2'>
									<span className='text-gray-800 font-semibold'>Category: </span>
									<span className='text-gray-600'>{ product.category.name }</span>
								</p>
								<p className='space-x-2'>
									<span className='text-gray-800 font-semibold'>SKU: </span>
									<span className='text-gray-600'>BE45VGRT</span>
								</p>
							</div>
							<div className='flex items-baseline mb-1 space-x-2 font-roboto mt-4'>
								<p className='text-xl text-primary font-semibold'>{ `$${ product.price }` }</p>
							</div>

							<p className='mt-4 text-gray-600'>
								{ product.description }
							</p>

							<div className='pt-4'>
								<h3 className='text-sm text-gray-800 uppercase mb-1'>Size</h3>
								<div className='flex items-center gap-2'>
									<div className='size-selector'>
										<input type='radio' name='size' id='size-xs' className='hidden'/>
										<label
											htmlFor='size-xs'
											className='text-xs border border-gray-200 rounded-sm h-6 w-6 flex items-center justify-center cursor-pointer shadow-sm text-gray-600'>XS
										</label>
									</div>
									<div className='size-selector'>
										<input type='radio' name='size' id='size-sm' className='hidden'/>
										<label
											htmlFor='size-sm'
											className='text-xs border border-gray-200 rounded-sm h-6 w-6 flex items-center justify-center cursor-pointer shadow-sm text-gray-600'>S
										</label>
									</div>
									<div className='size-selector'>
										<input type='radio' name='size' id='size-m' className='hidden'/>
										<label
											htmlFor='size-m'
											className='text-xs border border-gray-200 rounded-sm h-6 w-6 flex items-center justify-center cursor-pointer shadow-sm text-gray-600'>M
										</label>
									</div>
									<div className='size-selector'>
										<input type='radio' name='size' id='size-l' className='hidden'/>
										<label
											htmlFor='size-l'
											className='text-xs border border-gray-200 rounded-sm h-6 w-6 flex items-center justify-center cursor-pointer shadow-sm text-gray-600'>L
										</label>
									</div>
									<div className='size-selector'>
										<input type='radio' name='size' id='size-xl' className='hidden'/>
										<label
											htmlFor='size-xl'
											className='text-xs border border-gray-200 rounded-sm h-6 w-6 flex items-center justify-center cursor-pointer shadow-sm text-gray-600'>XL
										</label>
									</div>
								</div>
							</div>

							<div className='pt-4'>
								<h3 className='text-xl text-gray-800 mb-3 uppercase font-medium'>Color</h3>
								<div className='flex items-center gap-2'>
									<div className='color-selector'>
										<input type='radio' name='color' id='red' className='hidden'/>
										<label
											htmlFor='red'
											className='border border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'
											style={ {
												backgroundColor: '#fc3d57'
											} }></label>
									</div>
									<div className='color-selector'>
										<input type='radio' name='color' id='black' className='hidden'/>
										<label
											htmlFor='black'
											className='border border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'
											style={ {
												backgroundColor: '#000'
											} }></label>
									</div>
									<div className='color-selector'>
										<input type='radio' name='color' id='white' className='hidden'/>
										<label
											htmlFor='white'
											className='border border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'
											style={ {
												backgroundColor: '#fff'
											} }></label>
									</div>

								</div>
							</div>

							<div className='mt-4'>
								<h3 className='text-sm text-gray-800 uppercase mb-1'>Quantity</h3>
								<div className='flex border border-gray-300 text-gray-600 divide-x divide-gray-300 w-max'>
									<div
										className='h-8 w-8 text-xl flex items-center justify-center cursor-pointer select-none'
										onClick={ () => setQuantityValue(quantityValue <= 0 ? 0 : quantityValue - 1) }>-
									</div>
									<div className='h-8 w-8 text-base flex items-center justify-center'>{ quantityValue }</div>
									<div
										className='h-8 w-8 text-xl flex items-center justify-center cursor-pointer select-none'
										onClick={ () => setQuantityValue(quantityValue + 1) }>+
									</div>
								</div>
							</div>

							<div className='mt-6 flex gap-3 border-b border-gray-200 pb-5 pt-5'>
								<button
									onClick={ () => handleAddToCart(product) }
									className='bg-primary border border-primary text-white px-8 py-2 font-medium rounded uppercase flex items-center gap-2 hover:bg-transparent hover:text-primary transition'>
									Add to cart
								</button>
							</div>

							<div className='flex gap-3 mt-4'>
								<a
									href='#'
									className='text-gray-400 hover:text-gray-500 h-8 w-8 rounded-full border border-gray-300 flex items-center justify-center'>
									<i className='fa-brands fa-facebook-f'></i>
								</a>
								<a
									href='#'
									className='text-gray-400 hover:text-gray-500 h-8 w-8 rounded-full border border-gray-300 flex items-center justify-center'>
									<i className='fa-brands fa-twitter'></i>
								</a>
								<a
									href='#'
									className='text-gray-400 hover:text-gray-500 h-8 w-8 rounded-full border border-gray-300 flex items-center justify-center'>
									<i className='fa-brands fa-instagram'></i>
								</a>
							</div>
						</div>
					</div>

					<div className='container pb-16'>
						<h3 className='border-b border-gray-200 font-roboto text-gray-800 pb-3 font-medium'>Product details</h3>
						<div className='w-3/5 pt-6'>
							{ product.description }
						</div>
					</div>

					<div className='container pb-16'>
						<h2 className='text-2xl font-medium text-gray-800 uppercase mb-6'>Related products</h2>
						<div className='grid grid-cols-4 gap-6'>
							{
								productRelated?.data?.slice(0, 3).filter(p => p.id != product?.id).map(( product, index ) => {
									return <div className='bg-white shadow rounded overflow-hidden group'>
										<div className='relative'>
											<img src={ product.image } alt='product 1' className='w-full rounded-xl'/>
											<div
												className='absolute inset-0 bg-black bg-opacity-40 flex items-center
                    justify-center gap-2 opacity-0 group-hover:opacity-100 transition'>
												<a
													href='#'
													className='text-white text-lg w-9 h-8 rounded-full bg-primary flex items-center justify-center hover:bg-gray-800 transition'
													title='view product'>
													<i className='fa-solid fa-magnifying-glass'></i>
												</a>
												<a
													href='#'
													className='text-white text-lg w-9 h-8 rounded-full bg-primary flex items-center justify-center hover:bg-gray-800 transition'
													title='add to wishlist'>
													<i className='fa-solid fa-heart'></i>
												</a>
											</div>
										</div>
										<div className='pt-4 pb-3 px-4'>
											<Link to={ `/product/${ product.id }` }>
												<h4
													className='uppercase line-clamp-1 font-medium text-xl mb-2 text-gray-800 hover:text-primary transition'>
													{ product.name }
												</h4>
											</Link>
											<div className='flex items-baseline mb-1 space-x-2'>
												<p className='text-xl text-primary font-semibold'>{ `$${ product.price }` }</p>
											</div>
										</div>
										<a
											href='#'
											className='block w-full py-1 text-center text-white bg-primary border border-primary rounded-b hover:bg-transparent hover:text-primary transition'>Add
										                                                                                                                                                     to cart
										</a>
									</div>
								})
							}
						</div>
					</div>
				</>
			)
		}

		</body>
	)
}

export default ProductDetailPage;
