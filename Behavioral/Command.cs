using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModel.Behavioral
{
    //接收者
    public class Television
    {
        public void Open()
        {
            Console.WriteLine("打开电视机");
        }
        public void Close()
        {
            Console.WriteLine("关闭电视机");
        }
        public void ChangeChannel(int i)
        {
            Console.WriteLine($"切换电视台:{i}");
        }
    }

    public interface ICommand
    {
        void Excute(int i);
    }

    public class OpenCommand : ICommand
    {
        private Television television;
        public OpenCommand()
        {
            television = new Television();
        }

        public void Excute(int i)
        {
            television.Open();
        }
    }

    public class CloseCommand : ICommand
    {
        private Television television;
        public CloseCommand()
        {
            television = new Television();
        }

        public void Excute(int i)
        {
            television.Close();
        }
    }
    public class ChangeChannelCommand : ICommand
    {
        private Television television;
        public ChangeChannelCommand()
        {
            television = new Television();
        }

        public void Excute(int i)
        {
            television.ChangeChannel(i);
        }
    }
    //调用者
    public class Invoke
    {
        private ICommand m_openCommand;
        private ICommand m_closeCommand;
        private ICommand m_changeChannelCommand;

        public int m_curChannel = 0;
        public int m_PreviousChannel;
        
        public Invoke(ICommand openCommand, ICommand closeCommand, ICommand changeChannelCommand)
        {
            m_openCommand = openCommand;
            m_closeCommand = closeCommand;
            m_changeChannelCommand = changeChannelCommand;
        }

        public void Open()
        {
            m_openCommand.Excute(0);
        }
        public void Close()
        {
            m_closeCommand.Excute(0);
        }
        public void ChangeChannel(int newChannel)
        {
            m_PreviousChannel = m_curChannel;
            m_curChannel = newChannel;
            m_changeChannelCommand.Excute(newChannel);
        }

        public void ChannelUndo()
        {
            m_changeChannelCommand.Excute(m_PreviousChannel);
            m_curChannel = m_curChannel + m_PreviousChannel;
            m_PreviousChannel = m_curChannel - m_PreviousChannel;
            m_curChannel = m_curChannel - m_PreviousChannel;
        }
    }
    internal class Command
    {
    }
}
