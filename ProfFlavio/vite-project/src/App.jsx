import { useState } from 'react'
import './App.css'
//importando o header
import Header from './Header'
import Section from './Section'


export default function App() {

  return (
    <>
      {/*Chamando a função header*/}
      <Header/>
      {/*Para separar o que cada section ir mostrar, passamos parametros*/}
      <Section tipo="sobre" titulo="Sobre Mim"
       subtitulo="Com formação em Mecanica de Precisão, atuei durante 15 anos
       na area. 
       10 anos como tecnico em mecânica de precisão realizando manutenções preventivas e corretivas
       em maquinário industrial, e 5 anos com usinagem de peças e programacao de maquinas CNC.
       Passei por uma transição de carreira em 2022 com a oportunidade do bootcamp oferecida pela ATOS.
       Desde então, procurando melhorar meu conhecimento para continuar trilhando esse caminho."/>
      {/*Section para os filmes*/}      
      <Section tipo="filmes" titulo="Melhores Filmes que eu ja assisti"
      subtitulo="Melhores entre os melhores"/>
      {/*Section para Contatos*/ }
      <Section tipo="contatos"titulo="Contatos Pessoais e Profissionais"
      subtitulo=""/>
    </>

  )
}
