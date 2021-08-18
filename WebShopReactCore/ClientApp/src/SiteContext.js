import React from 'react';


export const SiteContext = React.createContext({
    cart: {},
    products: [],
    loading: true,
    currentBook: {},
    loadPage: "",
    setCurrentBook: (item) => { }
})