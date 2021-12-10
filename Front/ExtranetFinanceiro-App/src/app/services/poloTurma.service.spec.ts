/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PoloTurmaService } from './poloTurma.service';

describe('Service: PoloTurmas', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PoloTurmaService]
    });
  });

  it('should ...', inject([PoloTurmaService], (service: PoloTurmaService) => {
    expect(service).toBeTruthy();
  }));
});
