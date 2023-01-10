import React, { createContext, useEffect, useState } from "react";
import { getMe, User } from "../services/user/user.service";
import { useQuery } from "@tanstack/react-query";
import { TOKEN_TYPE } from "../libs/constant";
import Cookies from "js-cookie";

export interface IAuthContext {
	isAuth: boolean;
	setAuth: ( isAuth: boolean ) => void;
	isLoading: boolean;
	user?: User,
	status: "success" | "loading" | "error",
	getMeAgain: () => Promise<any>,
	logout: () => void
}

interface IAuthProvider {
	children: React.ReactNode;
}

export const AuthContext = createContext<IAuthContext | null>(null);
const AuthProvider: React.FC<IAuthProvider> = ( { children } ) => {
	const [isAuth, setAuth] = useState<boolean>(false);
	const [isLoading, setIsLoading] = useState(true);
	const [user, setUser] = useState<User>({});

	const { data, status, refetch } = useQuery(['GET_USER'], getMe, {
		onSuccess: ( data ) => {
			setIsLoading(false)
			setAuth(true)
			setUser(data)
		},
		onError: ( err ) => {
			setIsLoading(false)
			setAuth(false)
			setUser({});
		}
	})

	useEffect(() => {
		if (!isLoading && data)
			setUser(data)
	}, [data, isLoading])

	useEffect(() => {
		setIsLoading(true)
	}, [])

	const getMeAgain = async () => {
		await refetch();
	}

	const logout = () => {
		Cookies.remove(TOKEN_TYPE)
		setAuth(false);
		setUser({});
	}

	return (
		<AuthContext.Provider
			value={ {
				isAuth,
				setAuth,
				user,
				isLoading,
				status,
				getMeAgain,
				logout
			} }>
			{ children }
		</AuthContext.Provider>
	);
};

export default AuthProvider;
