import kupiapi.scraper
import json
import sys

sc = kupiapi.scraper.KupiScraper()
data = sc.get_discounts_by_search('monster energy')

sys.stdout.reconfigure(encoding='utf-8')

print(json.dumps(data, ensure_ascii=False))




