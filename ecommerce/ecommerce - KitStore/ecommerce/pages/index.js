import React from 'react';

import { client } from '../lib/client';
import { Product, FooterBanner, HeroBanner } from '../components';

const Home = ({ products, bannerData }) => (
  <div>
    <HeroBanner heroBanner={bannerData.length && bannerData[0]}  />
    <div className="products-heading">
      <h2>Sizin İçin Seçtiklerimiz</h2>
      <p>En çok satan formalar</p>
    </div>

    <div className="products-container">
      {products?.map((product) => <Product key={product._id} product={product} />)}
    </div>

    <FooterBanner footerBanner={bannerData && bannerData[0]} />
  </div>
);
export const getServerSideProps = async () => {
  const query = '*[_type == "product"]'; // all of the product
  const products = await client.fetch(query);

  const bannerQuery = '*[_type == "banner"]'; // all of the banner
  const bannerData = await client.fetch(bannerQuery);

  return {
    props: { products, bannerData }
  }
}

export default Home;


//in next.js, whenever you are fetching data from api we can 
//use the function getServerSideProps.
//whatever getServerSideProps returns thats get populated
//into our function