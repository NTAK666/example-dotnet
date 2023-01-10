import { FC, useState } from "react";
import SideBarComponent from "../components/shop/side-bar.component";
import ProductListComponent from "../components/shop/product-list.component";
import { useQuery } from "@tanstack/react-query";
import { getCategories } from "../services/category/category.services";
import { getProducts, getProductsByCategory } from "../services/product/product.services";
import { shuffle } from "../libs/array-lib";
import { useParams } from "react-router-dom";

type ShopPageProps = {}

const ShopPage: FC<ShopPageProps> = ( {} ) => {

	const { categoryId } = useParams();

	const [pageNumber, setPageNumber] = useState(0);
	const { data: categories } = useQuery(['GET_CATEGORIES'], getCategories);
	const {
		data: products,
		isFetching: productsFetching
	} = useQuery(['GET_PRODUCT', pageNumber], () => getProducts(pageNumber), {
		enabled: categoryId === undefined
	});

	const { data: productsByCategory } = useQuery(['GET_PRODUCT_BY_CATEGORY', categoryId, pageNumber], () => getProductsByCategory(categoryId!, pageNumber), {
		enabled: categoryId !== undefined
	});

	const onChangePage = ( page: number ) => {
		console.log(products)
		setPageNumber(page);
	}

	return (
		<body>

		<div className='container py-4 flex items-center gap-3'>
			<a href='../index.html' className='text-primary text-base'>
				<i className='fa-solid fa-house'></i>
			</a>
			<span className='text-sm text-gray-400'>
            <i className='fa-solid fa-chevron-right'></i>
        </span>
			<p className='text-gray-600 font-medium'>Shop</p>
		</div>

		<div className='container grid grid-cols-4 gap-6 pt-4 pb-16 items-start'>
			<SideBarComponent categories={ shuffle(categories?.data! || []) }/>
			<ProductListComponent
				products={ shuffle(categoryId === undefined ? products?.data! : productsByCategory?.data! || []) }
				pagination={ categoryId === undefined ? products : productsByCategory } currentPage={ pageNumber }
				changeCurrentPage={ onChangePage }
				isLoading={ productsFetching }
			/>
		</div>

		</body>
	)
}

export default ShopPage;
