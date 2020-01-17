import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CandleGraphTradingViewComponent } from './candle-graph-trading-view.component';

describe('CandleGraphTradingViewComponent', () => {
  let component: CandleGraphTradingViewComponent;
  let fixture: ComponentFixture<CandleGraphTradingViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CandleGraphTradingViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CandleGraphTradingViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
