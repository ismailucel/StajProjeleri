import React, { useState, useEffect } from 'react';
import Link from 'next/link';
import { BsBagCheckFill } from 'react-icons/bs';

import { useStateContext } from '../context/StateContext';
import { runFireworks } from '../lib/utils';

const Success = () => {
  const { setCartItems, setTotalPrice, setTotalQuantities } = useStateContext();
  
  useEffect(() => {
    localStorage.clear();
    setCartItems([]);
    setTotalPrice(0);
    setTotalQuantities(0);
    runFireworks();
  }, []);

  return (
    <div className="success-wrapper">
      <div className="success">
        <p className="icon">
          <BsBagCheckFill />
        </p>
        <h2>Siparişiniz için teşekkürler!</h2>
        <p className="email-msg">Fatura için e-mail'inizi kontrol edin.</p>
        <p className="description">
          Öneriniz varsa aşağıdaki adrese yazabilirsiniz.
          <a className="email" href="mailto:ismailucel@gmail.com">
            ismailucel@gmail.com
          </a>
        </p>
        <Link href="/">
          <button type="button" width="300px" className="btn">
            Alışverişe devam
          </button>
        </Link>
      </div>
    </div>
  )
}

export default Success