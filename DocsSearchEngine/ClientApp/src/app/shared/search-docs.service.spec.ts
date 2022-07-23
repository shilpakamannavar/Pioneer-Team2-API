import { TestBed } from '@angular/core/testing';

import { SearchDocsService } from './search-docs.service';

describe('SearchDocsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SearchDocsService = TestBed.get(SearchDocsService);
    expect(service).toBeTruthy();
  });
});
