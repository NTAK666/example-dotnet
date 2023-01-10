import { Category } from "../category/category.services";
import axios from "../../libs/axios";
import { PagedResponse } from "../../entities/common";
import Cookies from "js-cookie";
import { TOKEN_TYPE } from "../../libs/constant";

export const getProducts = async ( pageNumber: number = 0 ): Promise<PagedResponse<Product[]>> => {
	return await axios.get(`/products?PageNumber=${ pageNumber }`, {
		headers: {
			Authorization: 'Bearer ' +Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export const getProductsByCategory = async ( category: string, pageNumber: number = 0 ): Promise<PagedResponse<Product[]>> => {
	return await axios.get(`/products/get-by-category/` + category + `?PageNumber=${ pageNumber }`, {
		headers: {
			Authorization: 'Bearer ' +Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export const getProductById = async ( id: string | undefined ): Promise<Product> => {
	return await axios.get('/products/get/' + id, {
		headers: {
			Authorization: 'Bearer ' +Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export type Product = {
	id: string,
	createdAt: Date,
	updatedAt: Date,
	isDeleted: boolean,
	name: string,
	price: string,
	description: string,
	image: string,
	gallary: [
		string
	],
	category: Category,
	categoryId: string
}
