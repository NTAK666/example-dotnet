import axios from "../../libs/axios";
import { PagedResponse } from "../../entities/common";
import { User } from "../user/user.service";
import Cookies from "js-cookie";
import { TOKEN_TYPE } from "../../libs/constant";

export const createOrder = async ( order: CreateOrder ) => {
	return await axios.post("/orders/add-order", order, {
		headers: {
			Authorization: 'Bearer ' + Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export const getOrders = async (): Promise<PagedResponse<OrderResponse[]>> => {
	return await axios.get('/orders/get-order-by-user', {
		headers: {
			Authorization: 'Bearer ' + Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export type CreateOrder = {
	orderDetails: CreateOrderItem[]
}

export type CreateOrderItem = {
	productId: string,
	quantity: number
}

export type OrderResponse = {
	user: User
	orderDetails: [
		{
			product: {
				id: string,
				createdAt: Date,
				updatedAt: Date,
				isDeleted: true,
				name: string,
				price: string,
				description: string,
				image: string,
				gallary: string[],
				category: {
					id: string,
					createdAt: Date,
					updatedAt: Date,
					isDeleted: true,
					name: string,
					image: string
				},
				categoryId: string
			},
			quantity: number
		}
	],
	status: number
}
