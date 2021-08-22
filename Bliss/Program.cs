﻿using System;
using Unity;
using Bliss.Manager;
using Bliss.States;
using Bliss.States.Game;

namespace Bliss
{
    public static class Program
    {
        public static IUnityContainer UnityContainer = new UnityContainer();

        [STAThread]
        static void Main()
        {
            Register();

            using JamGame game = UnityContainer.Resolve<JamGame>();
            game.Run();
        }

        static void Register()
        {
            RegisterManager();
            RegisterStates();

            UnityContainer.RegisterSingleton<JamGame>();
        }

        static void RegisterManager()
        {
            UnityContainer.RegisterType<ContentManager>();
            UnityContainer.RegisterType<AudioManager>();
            UnityContainer.RegisterType<ParticleManager>();
            UnityContainer.RegisterType<StateManager>();
            UnityContainer.RegisterType<AnimationManager>();
        }

        static void RegisterStates()
        {
            UnityContainer.RegisterType<DefaultState>(DefaultState.Name);
            UnityContainer.RegisterType<DefaultState>(GameState.Name);
        }
    }
}
