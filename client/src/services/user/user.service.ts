import axios from "../../libs/axios";
import Cookies from "js-cookie";
import { TOKEN_TYPE } from "../../libs/constant";

export const login = async ( { email, password }: { email: string, password: string } ): Promise<Token> => {
	return await axios.post('/auth/login', { email, password }, {
		headers: {
			Authorization: 'Bearer ' +Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export const getMe = async (): Promise<User> => {
	return await axios.get('/auth/me', {
		headers: {
			Authorization: 'Bearer ' +Cookies.get(TOKEN_TYPE)
		}
	}).then(res => res.data);
}

export type Token = {
	accessToken: string,
	tokenExpires: Date,
	tokenType: string
}

export type User = {
	id?: string,
	createdAt?: Date,
	updatedAt?: Date,
	isDeleted?: true,
	bio?: string,
	email?: string,
	userName?: string,
	fullName?: string,
	avatar?: string,
	address?: string
}
