using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 顺序表_第一周
{ 
    class CSeqList<Type>//顺序表泛型类
    {
        private Type[] data;//顺序表数据
        private int MaxSize;//最大空间
        private int datasize;//实际元素个数

        public CSeqList(int MaxSize)//构造函数, 构造函数可用于为某些成员变量设置初始值
        {
            this.MaxSize = MaxSize; //当成员函数中某个变量与成员变量名字相同，则使用this关键字来表示成员变量
            data = new Type[MaxSize]; //开辟一段新的空间
            datasize = 0;
        }

        public CSeqList(int MaxSize, Type[] data, int n)
        {
            this.MaxSize = MaxSize;
            this.data = new Type[MaxSize];
            for (int i = 0; i < n; i++)
                this.data[i] = data[i];
            datasize = n;
        }

        // 插入
        public bool Inset(int k, Type dt)
        {
            //if (k < 1 || k > datasize + 1) return false;
            //if (datasize == MaxSize) return false;
            //for (int i = 0; i <= datasize - k; i++)
            //{
            //    data[datasize - i] = data[datasize - i - 1];
            //}
            //data[k - 1] = dt;
            //datasize++;
            //return true;
            if (k < 1 || k > datasize + 1)
                return false;
            if (datasize == MaxSize)
                return false;
            for (int i = datasize - 1; i >= k - 1; i--)
                data[i + 1] = data[i];
            data[k - 1] = dt;
            datasize++;
            return true;
        }

        // 删除
        public bool Delete(int k)
        {
            if (k < 1 || k > datasize)
                return false;
            for (int i = k - 1; i < datasize - 1; i++)
                data[i] = data[i + 1];
            datasize--;
            return true;
        }

        // 更新
        public bool Update(int k, Type dt)
        {
            if (k < 1 || k > datasize)
                return false;
            data[k - 1] = dt;
            return true;
        }

        // 置空
        public void MakeEmpty()
        {
            datasize = 0;
        }

        // 求表长
        public int DataSize
        {
            get
            {
                return datasize;
            }
        }

        public void reverse()
        {
            Type[] dt = new Type[datasize];
            Array.Copy(data, dt, datasize); //data复制给dt
            for (int i = 0;i < datasize; i++)
            {
                data[i] = dt[datasize - i - 1];
            }
        }

        // 显示输出
        public string MyPrint()
        {
            string strout = "";
            for (int i = 0; i < MaxSize; i++)
            {
                if (i < datasize)
                {
                     strout += "      " + (i + 1) + "      \t【      " + data[i] + "\t】\n";
                }       
                else // 打印空的
                     strout += "      " + (i + 1) + "      \t【      " + "\t】\n";            
            }
            return strout;
        }
        // 逆转
        public void Reverse()
        {
            if (this.datasize == 0)
            {
                throw new Exception("当前顺序表中的元素个数为0，无法逆转，请先进行初始化。");
            }
            for (int i = 0; i < datasize; i++)
            {
                this.data[datasize - i - 1] = this.data[i];
            }

        }
        // 元素查找
        public int Find(Type elemeny)
        {
            for (int i = 0; i < datasize; i++)
            {
                if (this.data[i].Equals(elemeny))
                    return i+1;
            }
            throw new Exception("没有找到指定的元素");
        }
    };
}
