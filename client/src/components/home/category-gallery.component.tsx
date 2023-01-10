import { FC } from "react";
import { Category } from "../../services/category/category.services";
import { Link } from "react-router-dom";

type CategoryGalleryComponentProps = {
	categories?: Category[]
}

const CategoryGalleryComponent: FC<CategoryGalleryComponentProps> = ( { categories } ) => {
	return (
		<div className='container py-16'>
			<h2 className='text-2xl font-medium text-gray-800 uppercase mb-6'>shop by category</h2>
			<div className='grid grid-cols-3 gap-3'>
				{
					categories?.slice(0, 6).map(( category, idx ) => {
						return <div className='relative rounded-2xl rounded-sm overflow-hidden group' key={ category.id }>
							<img src={ `${ category.image }?random=${ idx }` } alt='category 1' className='w-full'/>
							<Link
								to={ `/categories/${ category.id }` }
								className='absolute font-semibold inset-0 bg-black bg-opacity-40 flex items-center justify-center text-xl text-white font-roboto font-medium group-hover:bg-opacity-60 transition'>
								{ category.name }
							</Link>
						</div>
					})
				}
			</div>
		</div>

	)
}

export default CategoryGalleryComponent;
