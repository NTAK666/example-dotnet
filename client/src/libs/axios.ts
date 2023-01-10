import axios, { AxiosRequestConfig } from 'axios';
import Cookies from "js-cookie";
import { TOKEN_TYPE } from "./constant";

const instance = axios.create({
	baseURL: "http://localhost:5000/api",
	headers: {
		'Content-Type': 'application/json',
		'Accept': 'application/json',
	},
});

instance.defaults.headers.Authorization = 'Bearer ' + Cookies.get(TOKEN_TYPE)

instance.interceptors.request.use(( config: AxiosRequestConfig ) => {
	return config;
});

instance.interceptors.response.use(
	response => {
		return response.data ? response.data : response;
	},
	async error => {
		if (error.response) {
			return Promise.reject(error.response.data);
		} else {
			return Promise.reject(error);
		}
	}
);

export default instance;
