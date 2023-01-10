import { FC, FormEvent, useContext, useState } from "react";
import { useMutation } from "@tanstack/react-query";
import { login } from "../services/user/user.service";
import { TOKEN_TYPE } from "../libs/constant";
import { useNavigate } from "react-router-dom";
import { AuthContext, IAuthContext } from "../contexts/auth.context";
import Cookies from "js-cookie";

type LoginPageProps = {}

const LoginPage: FC<LoginPageProps> = ( {} ) => {
	const { mutateAsync: loginAsync } = useMutation(login)
	const [error, setError] = useState('')
	const [isLoading, setIsLoading] = useState<boolean>(false);


	const [loginPayload, setLoginPayload] = useState({
		email: '',
		password: ''
	})

	const navigate = useNavigate();

	const { getMeAgain } = useContext(AuthContext) as IAuthContext;

	const onLogin = ( e: FormEvent<HTMLFormElement> ) => {
		e.preventDefault();
		if (!loginPayload.email && !loginPayload.password) return;
		setIsLoading(true);
		loginAsync(loginPayload)
			.then(async res => {
				await Cookies.set(TOKEN_TYPE, res.accessToken);
				await getMeAgain();
				navigate('/')
			})
			.catch(res => {
				setError(res.data[0])
			}).finally(() => {
			setIsLoading(false)
		})
	}

	return (
		<>
			<div className='contain py-16'>
				<div className='max-w-lg mx-auto shadow px-6 py-7 rounded overflow-hidden'>
					<h2 className='text-2xl uppercase font-medium mb-1'>Login</h2>
					<p className='text-gray-600 mb-6 text-sm'>
						welcome back customer
					</p>
					{
						error != '' && (
							<div
								className='bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4'
								role='alert'>
								<span className='block sm:inline'>{ error }</span>
							</div>
						)
					}
					<form action='#' method='post' autoComplete='off' onSubmit={ onLogin }>
						<div className='space-y-2'>
							<div>
								<label htmlFor='email' className='text-gray-600 mb-2 block'>Email address</label>
								<input
									value={ loginPayload.email }
									onChange={ ( e ) => setLoginPayload({ ...loginPayload, email: e.target.value }) }
									type='email' name='email' id='email'
									className='block w-full border border-gray-300 px-4 py-3 text-gray-600 text-sm rounded focus:ring-0 focus:border-primary placeholder-gray-400'
									placeholder='youremail.@domain.com'/>
							</div>
							<div>
								<label htmlFor='password' className='text-gray-600 mb-2 block'>Password</label>
								<input
									value={ loginPayload.password }
									onChange={ ( e ) => setLoginPayload({ ...loginPayload, password: e.target.value }) }
									type='password' name='password' id='password'
									className='block w-full border border-gray-300 px-4 py-3 text-gray-600 text-sm rounded focus:ring-0 focus:border-primary placeholder-gray-400'
									placeholder='*******'/>
							</div>
						</div>
						<div className='flex items-center justify-between mt-6'>
							<div className='flex items-center'>
								<input
									type='checkbox' name='remember' id='remember'
									className='text-primary focus:ring-0 rounded-sm cursor-pointer'/>
								<label htmlFor='remember' className='text-gray-600 ml-3 cursor-pointer'>Remember me</label>
							</div>
							<a href='#' className='text-primary'>Forgot password</a>
						</div>
						<div className='mt-4'>
							<button
								disabled={ isLoading }
								type='submit'
								className='block w-full py-2 text-center text-white bg-primary border border-primary rounded hover:bg-transparent hover:text-primary transition uppercase font-roboto font-medium'>Login
							</button>
						</div>
					</form>

					<div className='mt-6 flex justify-center relative'>
						<div className='text-gray-600 uppercase px-3 bg-white z-10 relative'>Or login with</div>
						<div className='absolute left-0 top-3 w-full border-b-2 border-gray-200'></div>
					</div>
					<div className='mt-4 flex gap-4'>
						<a
							href='#'
							className='w-1/2 py-2 text-center text-white bg-blue-800 rounded uppercase font-roboto font-medium text-sm hover:bg-blue-700'>facebook
						</a>
						<a
							href='#'
							className='w-1/2 py-2 text-center text-white bg-red-600 rounded uppercase font-roboto font-medium text-sm hover:bg-red-500'>google
						</a>
					</div>

					<p className='mt-4 text-center text-gray-600'>Don't have account? <a
						href='register.html'
						className='text-primary'>Register
					                           now</a></p>
				</div>
			</div>
		</>
	)
}

export default LoginPage;
