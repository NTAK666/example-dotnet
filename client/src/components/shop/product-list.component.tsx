import { FC } from "react";
import { Product } from "../../services/product/product.services";
import { PagedResponse } from "../../entities/common";
import { AiFillStar } from "react-icons/ai";
import { Link } from "react-router-dom";

type ProductListComponentProps = {
	products?: Product[]
	pagination?: PagedResponse<Product[]>
	currentPage?: number
	changeCurrentPage: ( page: number ) => void
	isLoading?: boolean
}

const ProductListComponent: FC<ProductListComponentProps> = ( {
	                                                              products,
	                                                              isLoading,
	                                                              pagination,
	                                                              currentPage,
	                                                              changeCurrentPage
                                                              } ) => {
	return (
		<div className='col-span-3'>
			<div className='grid grid-cols-3 gap-6'>
				{
					isLoading ? (
						<div className='h-[800px]'>Fetching ... </div>
					) : (
						<>
							{
								products?.slice(0, 9).map(( product, index ) => {
									return <div className='bg-white shadow rounded overflow-hidden group' key={ product.id }>
										<div className='relative'>
											<img src={ `${ product.image }` } alt='product 1' className='w-full rounded-tr-xl rounded-tl-xl'/>
											<div
												className='absolute inset-0 bg-black bg-opacity-40 flex items-center
                        justify-center gap-2 opacity-0 group-hover:opacity-100 transition'>
											</div>
										</div>
										<div className='pt-4 pb-3 px-4'>
											<Link
												to={ `/product/${ product.id }` }
												className='uppercase font-medium text-xl mb-2 text-gray-800 hover:text-primary transition line-clamp-1'>
												{ product.name }
											</Link>
											<div className='flex items-baseline mb-1 space-x-2'>
												<p className='text-xl text-primary font-semibold'>{ `$${product.price}` }</p>
											</div>
											<div className='flex items-center'>
												<div className='flex gap-1 text-sm text-yellow-400'>
													<AiFillStar/>
													<AiFillStar/>
													<AiFillStar/>
													<AiFillStar/>
													<AiFillStar/>
												</div>
												<div className='text-xs text-gray-500 ml-3'>(150)</div>
											</div>
										</div>
										{/*<a*/ }
										{/*	href='#'*/ }
										{/*	className='block w-full py-1 text-center text-white bg-primary border border-primary rounded-b hover:bg-transparent hover:text-primary transition'>Add*/ }
										{/*                                                                                                                                                     to cart*/ }
										{/*</a>*/ }
									</div>
								})
							}
						</>
					)
				}
			</div>

			<div className='container mx-auto'>
				<div className='flex items-center gap-2 justify-center  mt-8'>
					{
						Array(pagination?.totalPages).fill(0).map(( _, idx ) => {
							return <span
								key={ idx }
								onClick={ () => changeCurrentPage(idx) }
								className={ `${ currentPage === idx ? 'bg-[#ff6e31]' : 'bg-[#1f2937]' } 
								hover:bg-opacity-90 transition-all duration-200 cursor-pointer px-3 py-2 rounded text-white font-semibold` }>
								{ idx + 1 }
							</span>
						})
					}
				</div>
			</div>
		</div>
	)
}

export default ProductListComponent;
