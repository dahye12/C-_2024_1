using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0411_01              // namespace 솔루션 이름
{
    internal class Car
    {
        // 속성 정의
        int carNum;                 // 차량 번호
        public DateTime inTime;    // 입차 시간
        public DateTime outTime;   // 출차 시간
                                   // public --> 공공의 라는 뜻으로, 모든 곳에 접근 가능하게 함

        public void SetInTime()     // 입차 시간 메서드
        {
            this.inTime = DateTime.Now;     // DataTime.Now --> 현재 시각을 출력함
        }
        public void SetOutTime()    // 출차 시간 메서드
        {
            this.outTime = DateTime.Now;
        }
    }
}
