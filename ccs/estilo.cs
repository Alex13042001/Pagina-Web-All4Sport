:root{
  --verde:#1BA87A;
  --naranja:#F58A2E;
  --blanco:#ffffff;
  --negro:#222222;
  --gris:#F4F4F4;
}
*{box-sizing:border-box}
body{font-family:Roboto,Arial,Helvetica,sans-serif;margin:0;color:var(--negro);background:#fff}
.container{max-width:1100px;margin:0 auto;padding:0 16px}
header{background:#fff;border-bottom:1px solid #e8e8e8;position:sticky;top:0;z-index:10}
.header-inner{display:flex;align-items:center;justify-content:space-between;padding:16px 0}
.logo{color:var(--verde);font-weight:700}
.main-nav a{margin:0 10px;text-decoration:none;color:var(--negro)}
.hero{background:var(--gris);padding:24px 0}
.hero-inner{display:flex;align-items:center;gap:20px;max-width:1100px;margin:0 auto;padding:20px}
.hero img{width:50%;height:auto;border-radius:6px}
.hero-text h2{font-size:40px;margin:0;color:var(--negro)}
.btn{display:inline-block;padding:10px 16px;border-radius:8px;text-decoration:none}
.btn.primary{background:var(--verde);color:#fff}
.btn.secondary{background:var(--naranja);color:#fff}
.categorias .cards{display:flex;gap:16px;flex-wrap:wrap;padding:20px}
.card{background:#fff;padding:12px;border:1px solid #e6e6e6;border-radius:6px;text-align:center;width:220px}
.productos-grid{display:grid;grid-template-columns:repeat(4,1fr);gap:16px;padding:20px}
.producto{background:#fff;padding:8px;border:1px solid #e6e6e6;border-radius:6px;text-align:center}
.footer{padding:24px;text-align:center}
footer{background:#fff;border-top:1px solid #e8e8e8;padding:16px 0;margin-top:40px}
@media(max-width:900px){
  .hero-inner{flex-direction:column}
  .productos-grid{grid-template-columns:repeat(2,1fr)}
  .card{width:calc(50% - 16px)}
}
