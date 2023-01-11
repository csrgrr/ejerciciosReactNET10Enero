import React from 'react'
import ReactDOM from 'react-dom/client'
import Card from './Card'
import Header from './Header'
import './index.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <>
    <Header />
    <article>
    <Card />
    <Card />
    <Card />
    <Card />
    <Card />
    <Card />
    <Card />
    <Card />
    </article>

    </>
    
  </React.StrictMode>,
)
