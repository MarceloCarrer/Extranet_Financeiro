import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PoloRelatoriosComponent } from './Components/polo-relatorios/polo-relatorios.component';
import { RelatoriosComponent } from './Components/relatorios/relatorios.component';
import { LoginComponent } from './Components/user/login/login.component';
import { UserComponent } from './Components/user/user.component';

const routes: Routes = [
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'login', component: LoginComponent }
    ]
  },
  {
    path: 'relatorios', component: RelatoriosComponent
  },
  {
    path: 'polo-relatorios/:relatorioId', component: PoloRelatoriosComponent
  },
  {
    path: '', redirectTo: 'relatorios', pathMatch: 'full'
  },
  {
    path: '**', redirectTo: 'relatorios', pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
