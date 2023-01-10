import { FC } from "react";
import { Link } from "react-router-dom";

type HeroComponentProps = {}

const HeroComponent: FC<HeroComponentProps> = ( {} ) => {
	return (
		<div
			className='bg-cover bg-no-repeat bg-center py-36' style={ {
			backgroundImage: 'url(https://picsum.photos/1920/1080?blur=2)'
		} }>
			<div className='container'>
				<h1 className='text-6xl text-white font-medium mb-4 capitalize'>
					best <span className='text-[#FF6E31]'>Ecommerce</span> for <br/> home and garden
				</h1>
				<p className='text-white'>
					Lorem, ipsum dolor sit amet consectetur adipisicing elit. Aperiam <br/>
					accusantium perspiciatis, sapiente
					magni eos dolorum ex quos dolores odio
				</p>
				<div className='mt-12'>
					<Link
						to='/categories' className='bg-primary border border-primary text-white px-8 py-3 font-medium
                    rounded-md hover:bg-transparent hover:text-primary'>
						Shop Now

					</Link>
				</div>
			</div>
		</div>

	)
}

export default HeroComponent;
