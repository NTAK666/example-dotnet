/** @type {import('tailwindcss').Config} */
module.exports = {
	content: [
		'./src/**/*.{js,jsx,ts,tsx}',
	],
	theme: {
		screen: {
			sm: '576px',
			md: '768px',
			lg: '992px',
			xl: '1200px',
		},
		container: {
			center: true,
			padding: '1rem',
		},
		extend: {
			fontFamily: {
				poppins: ['Poppins', 'sans-serif'],
				roboto: ['Roboto', 'sans-serif'],
			},
			colors: {
				primary: '#FF6E31',
			},
		},
	},
	plugins: [
		require('@tailwindcss/forms'),
		require('@tailwindcss/line-clamp'),
	],
};
