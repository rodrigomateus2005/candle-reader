import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BotViewComponent } from './Pages/bot-view/bot-view.component';

const routes: Routes = [
  {
    path: 'bot-view',
    component: BotViewComponent
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
