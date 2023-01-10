import axios from "../../libs/axios";
import { PagedResponse } from "../../entities/common";
import Cookies from "js-cookie";
import { TOKEN_TYPE } from "../../libs/constant";

export const getCategories = async (): Promise<PagedResponse<Category[]>> => {
	return await axios.get('/categories', {
		headers: {
			Authorization: 'Bearer ' + Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}


export type Category = {
	id: string,
	createdAt: Date,
	updatedAt: Date,
	isDeleted: boolean,
	name: string,
	image: string
}
