/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PoloRelatorioService } from './poloRelatorio.service';

describe('Service: PoloRelatorio', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PoloRelatorioService]
    });
  });

  it('should ...', inject([PoloRelatorioService], (service: PoloRelatorioService) => {
    expect(service).toBeTruthy();
  }));
});
