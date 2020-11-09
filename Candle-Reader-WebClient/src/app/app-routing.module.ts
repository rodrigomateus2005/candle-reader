import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BotViewComponent } from './Pages/bot-view/bot-view.component';
import { BrokerComponent } from './Pages/broker/broker.component';

const routes: Routes = [
  {
    path: 'home',
    component: BotViewComponent
  },
  {
    path: 'broker',
    component: BrokerComponent
  },
  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  },
  {
    path: '#/',
    redirectTo: '/home',
    pathMatch: 'full'
  },
  {
    path: '#',
    redirectTo: '/home',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
