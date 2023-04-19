import time

from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.by import By
from selenium.webdriver.chrome.service import Service
Path = 'C:/Users/Илья/Downloads/chromedriver_win32/chromedriver.exe'
s = Service(Path)
driver = webdriver.Chrome(service=s)

jpg_file = "C:/Users/Илья/Downloads/cotik.jpg"


def base_functionals_on_yt():
    driver.get("https://market.yandex.ru/")
    time.sleep(3)
    open_menu = driver.find_element(By.CSS_SELECTOR, "#catalogPopupButton")
    open_menu.click()
    time.sleep(3)
    in_trend = driver.find_element(By.CSS_SELECTOR, "#catalogPopup > div > div > div > div > div > div > div.EH4e7 > div > div > div > div._2HhF1 > div > div > div > div > div > div > div > div:nth-child(1) > div:nth-child(1) > ul > li:nth-child(1) > div")
    in_trend.click()
    time.sleep(3)
    open_video = driver.find_element(By.CSS_SELECTOR, "#searchFilters > div > div:nth-child(3) > div > div > div > div > div:nth-child(2) > div > fieldset > div > div > div > div:nth-child(1)")
    ActionChains(driver).send_keys_to_element(open_video, "1000").perform()
    time.sleep(10)
    Key_next = driver.find_element(By.CSS_SELECTOR, "#video-title-link")
    Key_next.click()
    time.sleep(10)

def base_functions():
    driver.get("https://stroydvor.su/")
    time.sleep(8)
    close = driver.find_element(By.CSS_SELECTOR, "#mCSB_2_container > a > i > svg")
    ActionChains(driver).move_by_offset(200, 200).click(close).perform()
    time.sleep(1)
    product1 = driver.find_element(By.CLASS_NAME, "compare_item_button")
    product1.click()
    time.sleep(2)
    sales = driver.find_element(By.CSS_SELECTOR, "#content > div.wrapper_inner.front.wide_page > div > div > div.drag-block.container.grey.CATALOG_TAB.grey_block.js-load-block > div > div > div > div > div > div > a")
    sales.click()
    time.sleep(2)
    catalog = driver.find_element(By.CSS_SELECTOR, "#bx_1847241719_19393 > table > tbody > tr > td.section_info.toggle > ul > li > a > span")
    catalog.click()
    time.sleep(2)
    product2 = driver.find_element(By.CLASS_NAME, "compare_item_button")
    product2.click()
    time.sleep(3)
    statistics = driver.find_element(By.CSS_SELECTOR, "#header > div.header-wrapper.fix-logo.header-v6 > div.menu-row.middle-block.bgcolored > div > div > div > div.right-icons.pull-right > div > div:nth-child(1) > a > span > i > svg > path")
    statistics.click()
    time.sleep(2)
    print("Все хорошо, мы автоматизировали кейс добавления товаров для сравнения")



if __name__ == '__main__':
    base_functions()