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
