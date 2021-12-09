import { ArticleAPIService } from "./article-api.service";

describe("Test getAllArticles returns 4", () => {

    let service = new ArticleAPIService();

    it("Should Return 4 ArticlePreviews", () => {
        expect(service.getAllArticles().length).toBe(4);
    });
    
});