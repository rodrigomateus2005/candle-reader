import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CandleGraphComponent } from './Components/candle-graph/candle-graph.component';
import { BotViewComponent } from './Pages/bot-view/bot-view.component';

@NgModule({
  declarations: [
    AppComponent,
    CandleGraphComponent,
    BotViewComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
