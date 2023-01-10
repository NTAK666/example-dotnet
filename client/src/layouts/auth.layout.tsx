import React, { FC, useContext } from "react";
import { AuthContext, IAuthContext } from "../contexts/auth.context";
import { Navigate } from "react-router-dom";
import MainLayout from "./main.layout";
import LoadingComponent from "../components/loading.component";

type AuthLayoutProps = {}

const AuthLayout: FC<AuthLayoutProps> = ( {} ) => {
	const { isAuth, isLoading, status } = useContext(AuthContext) as IAuthContext;

	return (
		<>
			{
				isLoading ? <LoadingComponent/> : isAuth ? <Navigate to='/'/> : <MainLayout/>
			}
		</>
	)

}

export default AuthLayout;
