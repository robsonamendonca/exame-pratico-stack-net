import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


// Importe os componentes necessários
import { SeguroComponent } from './seguro/seguro.component';

const routes: Routes = [
  // Configure uma rota para a página inicial (home)
  { path: '', component: SeguroComponent },
  { path: 'seguro', component: SeguroComponent },
  // Outras rotas aqui
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

