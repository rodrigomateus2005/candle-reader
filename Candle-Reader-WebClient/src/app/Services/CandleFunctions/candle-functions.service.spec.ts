import { TestBed } from '@angular/core/testing';

import { CandleFunctionsService } from './candle-functions.service';

describe('CandleFunctionsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CandleFunctionsService = TestBed.get(CandleFunctionsService);
    expect(service).toBeTruthy();
  });
});
