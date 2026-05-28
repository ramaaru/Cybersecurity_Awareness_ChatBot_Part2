using System;
using System.IO;
using System.Media;
using System.Speech.Synthesis;

namespace CyberSecurityBot
{
    public static class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            // Only attempt to play greeting.wav from Assets at startup.
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Assets",
                    "greeting.wav"
                );

                if (File.Exists(path))
                {
                    using (SoundPlayer player = new SoundPlayer(path))
                    {
                        // Play asynchronously so the UI thread isn't blocked at startup.
                        player.Play();
                    }
                }
            }
            catch
            {
                // Swallow exceptions to avoid interfering with application startup.
            }
        }
    }
}
