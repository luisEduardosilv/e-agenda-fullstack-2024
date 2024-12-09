import { Routes } from '@angular/router';
import { RegistroComponent } from './auth/views/registro/registro.component';
import { LoginComponent } from './auth/views/login/login.component';
import { DashboardComponent } from './views/dashboard/dashboard.component';
export const routes: Routes = [
{
path: 'registro',
title: 'Registro de Usuário | e-Agenda',
component: RegistroComponent,
},
{
path: 'login',

Shell
Modelos
title: 'Login de Usuário | e-Agenda',
component: LoginComponent,
},
{
path: 'dashboard',
title: 'Painel de Controle | e-Agenda',
component: DashboardComponent,
},
];
