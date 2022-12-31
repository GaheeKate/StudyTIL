# Python : simpleApps

Today I studied Python
- lotto
``` python
from random import shuffle
from time import sleep

gamenum = input('how many: ')

for i in range(int(gamenum)):
    balls = [x+1 for x in range(49)]
    ret = []
    for j in range(6):
        shuffle(balls)
        number = balls.pop()
        ret.append(number)
        ret.sort()
    print('lotto[%d]:' % (i+1), end='') #mind the line position
    print(ret)
    sleep(1)

```
- Data process
- count births by year
(https://catalog.data.gov/dataset/baby-names-from-social-security-card-applications-national-data)
``` python
def countBirths():
    ret = []
    for y in range(1880, 2021):
        count = 0
        filename = 'names/yob%d.txt' % y
        with open(filename, 'r') as f:#with as => auto close
            data = f.readlines()
            for d in data:
                if d[-1] == '\n': #reassign data except \n
                    d = d[:-1]

                birth = d.split(',')[2] #ex:Jessie,F,635 -> 635
                count += int(birth)
        ret.append((y, count))
    return ret


result = countBirths()
with open('birth_by_years.csv', 'w') as f:
    for year, birth in result:
        data = '%s,%s\n' % (year, birth)
        print(data)
        f.write(data)

```

- Web server log process
- Total page view
- apache web server access log
``` python
pageviews = 0

with open('access_log', 'r') as f:
    logs = f.readlines()
    for log in logs:
        log = log.split() #for apache, split by empty space, 9th code is status
        status = log(8)
        if status == '200':
            pageviews += 1

print('total page view: [%d]' % pageviews)

```
- unique visitor
``` python
visit_ip = []

with open('access_log', 'r') as f:
    logs = f.readlines()
    for log in logs:
        log = log.split() 
        ip=log[0]
        if ip not in visit_ip: #add ip if not exists
          visit_ip.append(ip)

print('unique visitors: [%d]' %len(visit_ip))

```