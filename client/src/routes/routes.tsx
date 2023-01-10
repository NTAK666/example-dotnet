import { createBrowserRouter } from "react-router-dom";
import MainLayout from "../layouts/main.layout";
import HomePage from "../pages/home.page";
import ShopPage from "../pages/shop.page";
import ProfilePage from "../pages/profile.page";
import PrivateLayout from "../layouts/private.layout";
import AuthLayout from "../layouts/auth.layout";
import LoginPage from "../pages/login.page";
import ProductDetailPage from "../pages/product-detail.page";
import CartPage from "../pages/cart.page";

const router = createBrowserRouter([
	{
		path: "/",
		element: <MainLayout/>,
		children: [
			{
				index: true,
				element: <HomePage/>
			},
			{
				path: "categories",
				element: <ShopPage/>,
				children: [
					{
						path: ":categoryId",
						element: <ShopPage/>
					}
				]
			},
			{
				path: "product/:productId",
				element: <ProductDetailPage/>,
			}
		]
	},
	{
		path: "auth",
		element: <AuthLayout/>,
		children: [
			{
				path: 'login',
				element: <LoginPage/>
			}
		]
	},
	{
		path: "profile",
		element: <PrivateLayout/>,
		children: [
			{
				path: '',
				element: <ProfilePage/>
			},
			{
				path: 'orders',
				element: <ProfilePage/>
			},
			{
				path: 'cart',
				element: <CartPage/>
			}
		]
	},
	{
		path: "*",
		element: <div>404</div>
	}
])
export default router;
