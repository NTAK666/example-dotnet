import { FC, lazy } from "react";
import HeroComponent from "../components/home/hero.component";
import ExtraComponent from "../components/home/extra.component";
import SaleBannerComponent from "../components/home/sale-banner.component";
import { useQuery } from "@tanstack/react-query";
import { getCategories } from "../services/category/category.services";
import { getProducts } from "../services/product/product.services";
import { shuffle } from "../libs/array-lib";

type HomePageProps = {}

const CategoryGalleryComponentLz = lazy(() => import("../components/home/category-gallery.component"));

const NewArrivalComponentLz = lazy(() => import("../components/home/new-arrival.component"));

const ProductListComponentLz = lazy(() => import("../components/home/product-list.component"));

const HomePage: FC<HomePageProps> = ( {} ) => {

	const { data: categories } = useQuery(['GET_CATEGORIES'], getCategories,
		{
			suspense: true,
		})

	const { data: products } = useQuery(['GET_PRODUCT'], () => getProducts(0), {
		suspense: true,
	})

	return (
		<>

			<HeroComponent/>

			<ExtraComponent/>

			<CategoryGalleryComponentLz categories={ categories?.data! || [] }/>

			<NewArrivalComponentLz products={ shuffle(products?.data! || []) }/>

			<SaleBannerComponent/>

			<ProductListComponentLz products={ shuffle(products?.data! || []) }/>

		</>
	)
}

export default HomePage;
