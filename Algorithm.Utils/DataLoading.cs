using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Algorithm.Utils
{
    public static class DataLoading
    {
        public static IEnumerable<int> StreamFileOutAsInts(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);
            string currentLine = streamReader.ReadLine();

            while (currentLine != null)
            {
                if (int.TryParse(currentLine.AsSpan(), out var output))
                {
                    yield return output;
                }
            }
        }

        public static async IAsyncEnumerable<int> StreamFileOutAsIntsAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);
            string currentLine;

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (int.TryParse(currentLine.AsSpan(), out var output))
                {
                    yield return output;
                }
            }
        }

        public static async Task<int[]> GetIntArrayFromFileAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);

            string currentLine;
            var ints = new List<int>();

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (int.TryParse(currentLine.AsSpan(), out var output))
                {
                    ints.Add(output);
                }
            }

            return ints.ToArray();
        }

        public static async Task<List<int>> GetIntListFromFileAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);

            string currentLine;
            var ints = new List<int>();

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (int.TryParse(currentLine.AsSpan(), out var output))
                {
                    ints.Add(output);
                }
            }

            return ints;
        }

        public static async IAsyncEnumerable<long> StreamFileOutAsLongsAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);
            string currentLine;

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (int.TryParse(currentLine.AsSpan(), out var output))
                {
                    yield return output;
                }
            }
        }

        public static async Task<long[]> GetLongArrayFromFileAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);

            string currentLine;
            var longs = new List<long>();

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (long.TryParse(currentLine.AsSpan(), out var output))
                {
                    longs.Add(output);
                }
            }

            return longs.ToArray();
        }

        public static async Task<List<long>> GetLongListFromFileAsync(string filePathName)
        {
            if (string.IsNullOrWhiteSpace(filePathName)) throw new ArgumentNullException(nameof(filePathName));
            if (!File.Exists(filePathName)) throw new ArgumentException($"{filePathName} is not a valid file path.");

            using var streamReader = File.OpenText(filePathName);

            string currentLine;
            var longs = new List<long>();

            while ((currentLine = await streamReader.ReadLineAsync().ConfigureAwait(false)) != null)
            {
                if (long.TryParse(currentLine.AsSpan(), out var output))
                {
                    longs.Add(output);
                }
            }

            return longs;
        }
    }
}
