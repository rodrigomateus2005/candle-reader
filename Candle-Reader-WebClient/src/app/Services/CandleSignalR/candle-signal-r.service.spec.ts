import { TestBed } from '@angular/core/testing';

import { CandleSignalRService } from './candle-signal-r.service';

describe('CandleSignalRService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CandleSignalRService = TestBed.get(CandleSignalRService);
    expect(service).toBeTruthy();
  });
});
