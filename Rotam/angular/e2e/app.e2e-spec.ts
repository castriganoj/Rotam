import { RotamTemplatePage } from './app.po';

describe('Rotam App', function() {
  let page: RotamTemplatePage;

  beforeEach(() => {
    page = new RotamTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
