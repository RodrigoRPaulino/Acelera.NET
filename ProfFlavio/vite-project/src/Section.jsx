{/*Para cada função que eu criar, eu preciso chamar na App
depois que eu passo os params chamo na funcao*/ }
export default function Section(props)
{
    switch(props.tipo)
    {
        case "sobre":return(
           <>
         <section>
            <div>
            <h2>{props.titulo}</h2>
              <p>{props.subtitulo}</p>
              <p>{props.tipo}</p>
            </div>
    
         </section>
           </> 
        )
        case "filmes":return(
            <>
               <section>
                <div>
                    <h2>{props.titulo}</h2>
                    <p>{props.subtitulo}</p>
                    <ul class="film-list">
    <li>
        <a href="https://www.youtube.com/watch?v=hHBsKHVLAYc" target="_blank">
            <img src="imagens/Interstellar.PNG" alt="Interestellar" title="Interestellar"/>
        </a>
    </li>
    <li>
        <a href="https://www.youtube.com/watch?v=6adTi1uzYQc" target="_blank">
        <img src="imagens/Perfume.JPG" alt="Perfume" title="Perfume"/>
        </a>
    </li>
    <li>
        <a href="https://www.youtube.com/watch?v=GAf0nGq_FXQ" target="_blank">
        <img src="imagens/Schindler.JPG" alt="Schindler" title="Schindler"/>
        </a>
    </li>
    <li>
        <a href="https://www.youtube.com/watch?v=Y22NgkErOAk" target="_blank">
        <img src="imagens/sonho.JPG" alt="sonho" title="sonho"/>  
        </a>
    </li>
</ul>

                </div>
               </section>
            </>
        )
        case "contatos":return(
            <>
                <section>
                    <div>
                    <h2>Meus Contatos </h2>
            <p>Minhas redes sociais</p>
            <ul class="film-list">
                <li><a href="https://www.facebook.com/profile.php?id=100003000104991" target="_blank"><img src="imagens/facebook.JPEG"
                            alt="Logo Facebook" title="Logo Facebook"/></a></li>
                <li><a href="https://www.instagram.com/rodrigorpaulino/" target="_blank"><img
                            src="imagens/instagram.JPG" alt="Logo Instagram" title="Logo Instagram"/></a></li>
                <li><a href="https://www.linkedin.com/in/rodrigo-paulino-8a2bb4125/" target="_blank"><img src="imagens/linkedin.JPEG"
                            alt="Logo Linkedin" title="Logo Linkedin"/></a></li>
                <li><a href="https://github.com/RodrigoRPaulino" target="_blank"><img src="imagens/github.JPG"
                            alt="Logo Github" title="Logo GitHub"/></a></li>
                <li><a href="https://wa.me/5511968098505" target="_blank"><img src="imagens/whatsapp.JPEG" alt="Logo Whatsapp"
                            title="Logo Whatsapp"/></a></li>
            </ul>
                    </div>
                </section>            
            </>
        )
    }
   
}


