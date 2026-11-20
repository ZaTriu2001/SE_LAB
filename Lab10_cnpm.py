from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.support.ui import Select
from time import sleep


# ======================
#  SETUP SELENIUM
# ======================
def init_driver():
    return webdriver.Chrome(service=Service(ChromeDriverManager().install()))


# ======================
#  BÀI 1 – LOGIN FACEBOOK
# ======================
def bai1():
    print("\n=== BÀI 1 ===")
    driver = init_driver()
    driver.get("https://facebook.com")
    driver.maximize_window()

    sleep(2)

    driver.find_element(By.ID, "email").send_keys("email")
    driver.find_element(By.ID, "pass").send_keys("mk")
    driver.find_element(By.ID, "pass").send_keys(Keys.ENTER)

    sleep(5)
    print("Title:", driver.title)

    driver.quit()


# ======================
#  BÀI 2 – LOGIN ELearning & LẤY THÔNG BÁO
# ======================
def bai2():
    print("\n=== BÀI 2 ===")
    driver = init_driver()
    driver.get("https://elit.tdtu.edu.vn")
    driver.maximize_window()

    sleep(2)

    driver.find_element(By.ID, "username").send_keys("523H0130")
    driver.find_element(By.ID, "password").send_keys("Password")
    driver.find_element(By.ID, "loginbtn").click()


    sleep(4)

    course = driver.find_element(By.CSS_SELECTOR, ".coursebox .coursename a")
    course_name = course.text
    course.click()

    sleep(3)
    print("Môn học:", course_name)

    ann = driver.find_elements(By.CSS_SELECTOR, ".event .name a")
    dates = driver.find_elements(By.CSS_SELECTOR, ".event .date")

    print("\n--- Danh sách thông báo ---")
    for a, d in zip(ann, dates):
        print(f"- {a.text} | {d.text}")

    driver.quit()


# ======================
#  BÀI 3 – UPLOAD FILE & LẤY LINK
# ======================
def bai3():
    print("\n=== BÀI 3 ===")
    driver = init_driver()
    driver.get("https://uploadfiles.io/")
    driver.maximize_window()

    sleep(2)

    file_input = driver.find_element(By.CSS_SELECTOR, "input[type='file']")
    file_input.send_keys(r"C:\Users\Dung\Desktop\test.png")

    sleep(10)

    link = driver.find_element(By.CSS_SELECTOR, ".uploaded-file-link").get_attribute("href")
    print("Link file upload:", link)

    driver.quit()


# ======================
#  BÀI 4 – TRẮC NGHIỆM 20 CÂU
# ======================
def bai4():
    print("\n=== BÀI 4 ===")

    answers = []
    with open("answers.txt", "r") as f:
        answers = [line.strip().upper() for line in f.readlines()]

    driver = init_driver()
    driver.get("http://guidetogrammar.org/grammar/quizzes/preposition_quiz1.htm")
    driver.maximize_window()

    sleep(2)

    questions = driver.find_elements(By.CSS_SELECTOR, "select")

    for i, q in enumerate(questions):
        q.send_keys(answers[i])

    sleep(1)

    driver.find_element(By.CSS_SELECTOR, "input[type='submit']").click()
    sleep(2)

    result = driver.find_element(By.CSS_SELECTOR, "body").text
    print("Kết quả:\n", result)

    driver.quit()


# ======================
#  BÀI 5 – TÌM VÉ VIETJET
# ======================
def bai5():
    print("\n=== BÀI 5 ===")

    driver = init_driver()
    driver.get("https://www.vietjetair.com/")
    driver.maximize_window()

    sleep(3)

    driver.find_element(By.ID, "origin").send_keys("Ho Chi Minh")
    driver.find_element(By.ID, "destination").send_keys("Ha Noi")
    driver.find_element(By.ID, "departure").send_keys("01/12/2017")
    driver.find_element(By.ID, "search-flight").click()

    sleep(5)

    sky = driver.find_element(By.CSS_SELECTOR, ".skyboss .select-flight")
    sky.click()

    sleep(3)

    driver.find_element(By.ID, "firstname").send_keys("Nguyen")
    driver.find_element(By.ID, "lastname").send_keys("Van A")
    driver.find_element(By.ID, "dob").send_keys("01/01/1999")

    sleep(2)

    Select(driver.find_element(By.ID, "payment-method")).select_by_visible_text("Master Card")

    driver.find_element(By.ID, "card-number").send_keys("5555555555554444")
    driver.find_element(By.ID, "expiry").send_keys("12/28")
    driver.find_element(By.ID, "cvv").send_keys("123")

    sleep(2)

    total = driver.find_element(By.ID, "total-price").text
    print("Tổng tiền:", total)

    driver.quit()


# ======================
#  CHẠY TOÀN BỘ BÀI
# ======================
if __name__ == "__main__":
    bai1()
    bai2()
    bai3()
    bai4()
    bai5()
