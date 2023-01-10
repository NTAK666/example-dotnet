import { FC } from "react";
import { Product } from "../../services/product/product.services";
import { AiFillStar } from "react-icons/ai";
import { Link } from "react-router-dom";

type ProductListComponentProps = {
	products?: Product[]
}

const ProductListComponent: FC<ProductListComponentProps> = ( { products } ) => {
	return (
		<div className='container pb-16'>
			<h2 className='text-2xl font-medium text-gray-800 uppercase mb-6'>recomended for you</h2>
			<div className='grid grid-cols-4 gap-6'>
				{
					products?.slice(0, 8).map(( product, idx ) => {
						return <div className='bg-white shadow rounded overflow-hidden group' key={ idx }>
							<div className='relative'>
								<img src={ `${ product.image }` } alt='product 1' className='w-full rounded-tr-xl rounded-tl-xl'/>
								<div
									className='absolute inset-0 bg-black bg-opacity-40 flex items-center
                    justify-center gap-2 opacity-0 group-hover:opacity-100 transition'>
								</div>
							</div>
							<div className='pt-4 pb-3 px-4 '>
								<Link
									to={ `/product/${ product.id }` }
									className='uppercase line-clamp-1 font-medium text-xl mb-2 text-gray-800 hover:text-primary transition line-clamp-2'>
									{ product.name }
								</Link>
								<div className='flex items-baseline mb-1 space-x-2'>
									<p className='text-xl text-primary font-semibold'>{ `$${ product.price }` }</p>
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
							{/*	href='src/components#'*/ }
							{/*	className='block w-full py-1 text-center text-white bg-primary border border-primary rounded-b hover:bg-transparent hover:text-primary transition'>Add*/ }
							{/*                                                                                                                                                     to cart*/ }
							{/*</a>*/ }
						</div>
					})
				}
			</div>
		</div>
	)
}

export default ProductListComponent;
