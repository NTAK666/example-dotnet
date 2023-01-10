import { FC } from "react";
import { Category } from "../../services/category/category.services";

type SideBarComponentProps = {
	categories?: Category[]
}

const SideBarComponent: FC<SideBarComponentProps> = ( { categories } ) => {
	return (
		<div className='col-span-1 bg-white px-4 pb-6 shadow rounded overflow-hidden'>
			<div className='divide-y divide-gray-200 space-y-5'>
				<div>
					<h3 className='text-xl text-gray-800 mb-3 uppercase font-medium'>Categories</h3>
					<div className='space-y-2'>
						{
							categories?.map(( category, index ) => {
								return <div className='flex items-center' key={ category.id }>
									<input
										type='checkbox' name='cat-1' id='cat-1'
										className='text-primary focus:ring-0 rounded-sm cursor-pointer'/>
									<label htmlFor='cat-1' className='text-gray-600 ml-3 cusror-pointer'>{ category.name }</label>
								</div>
							})
						}
					</div>
				</div>

				<div className='pt-4'>
					<h3 className='text-xl text-gray-800 mb-3 uppercase font-medium'>size</h3>
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
								className='border bg-[##fc3d57] border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'></label>
						</div>
						<div className='color-selector'>
							<input type='radio' name='color' id='black' className='hidden'/>
							<label
								htmlFor='black'
								className='border bg-[##000] border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'></label>
						</div>
						<div className='color-selector'>
							<input type='radio' name='color' id='white' className='hidden'/>
							<label
								htmlFor='white'
								className='border bg-[##fff] border-gray-200 rounded-sm h-6 w-6  cursor-pointer shadow-sm block'></label>
						</div>

					</div>
				</div>

			</div>
		</div>
	)
}

export default SideBarComponent;
