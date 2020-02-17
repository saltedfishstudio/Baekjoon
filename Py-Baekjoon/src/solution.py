class Solution(object):
	
	def n10699(self):
		from datetime import date
		print(date.today().strftime("%Y-%m-%d"))


	def n3046(self):
		x = input().split(' ')
		print(int(x[0])*2-int(x[0]))

	
	def n2163(self):
		x = input().split(' ')
		n = int(x[0])
		m = int(x[1])
		print((int(n)) * (int(m)) -1)


	def n2525(self):
		x = input().split(' ')
		hour = int(x[0])
		min = int(x[1])
		min += int(input())
		additionalHour = min // 60
		min = min % 60
		hour += additionalHour
		hour %= 24
		print(f'{hour} {min}')


	def n2530(self):
		x = input().split(' ')
		hour = int(x[0])
		min = int(x[1])
		sec = int(x[2])
		sec += int(input())
		add_min = sec // 60
		sec %= 60
		min += add_min
		add_hour = min // 60
		min %= 60
		hour += add_hour
		hour %= 24
		print(f'{hour} {min} {sec}')

	def n10250(self):
		for _ in range(int(input())):
			h,w,n=map(int, input().split())
			a=n%h
			b=n//h+1
			if a==0: 
				a = h
				b = -1
			print(a*100+b)

	def n2775(self):
		for _ in range(int(input())):
			k = int(input())
			n = int(input())