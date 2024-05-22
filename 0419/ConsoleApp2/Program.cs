import matplotlib.pyplot as plt
import numpy as np

# 명령어의 수 N
N_values = [10, 100, 1000, 10000]

# 파이프라이닝을 이용한 속도 향상 Sp
speedup_values = [5, 5, 5, 5]

# 로그 스케일로 표시하기 위해 log10(N) 값을 계산합니다.
log_N_values = np.log10(N_values)

# 그래프 그리기
plt.figure(figsize = (8, 6))
plt.plot(log_N_values, speedup_values, marker = 'o', linestyle = '-', color = 'b')
plt.title('Speedup with Pipelining vs. Number of Instructions')
plt.xlabel('log10(N) (Number of Instructions)')
plt.ylabel('Speedup with Pipelining')
plt.grid(True)
plt.xticks(log_N_values, N_values)
plt.show()
