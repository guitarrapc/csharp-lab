``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method | Number |       Mean |      Error |    StdDev |        Min |        Max |  Gen 0 |  Gen 1 | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** |      **1** |   **744.8 ns** |   **565.1 ns** |  **30.98 ns** |   **709.3 ns** |   **766.2 ns** | **0.0124** | **0.0114** |      **1 KB** |
|       AllocateString |      1 |   720.7 ns |   500.4 ns |  27.43 ns |   691.7 ns |   746.2 ns | 0.0124 | 0.0114 |      1 KB |
|          AllocateLoH |      1 |   703.8 ns |   254.4 ns |  13.94 ns |   687.9 ns |   713.7 ns | 0.0124 | 0.0114 |      1 KB |
|        AllocateArray |      1 |   729.1 ns |   509.1 ns |  27.90 ns |   697.0 ns |   747.3 ns | 0.0124 | 0.0114 |      1 KB |
|    AllocateArrayPool |      1 |   719.4 ns |   456.9 ns |  25.04 ns |   693.1 ns |   743.0 ns | 0.0124 | 0.0114 |      1 KB |
| **AllocateStringStatic** |     **10** | **7,654.8 ns** | **1,390.5 ns** |  **76.22 ns** | **7,575.4 ns** | **7,727.4 ns** | **0.1221** | **0.1144** |     **10 KB** |
|       AllocateString |     10 | 7,201.3 ns | 2,187.4 ns | 119.90 ns | 7,068.5 ns | 7,301.7 ns | 0.1221 | 0.1144 |     10 KB |
|          AllocateLoH |     10 | 7,208.1 ns | 1,761.8 ns |  96.57 ns | 7,136.2 ns | 7,317.9 ns | 0.1221 | 0.1144 |     10 KB |
|        AllocateArray |     10 | 7,516.6 ns | 3,814.8 ns | 209.10 ns | 7,288.4 ns | 7,699.0 ns | 0.1221 | 0.1144 |     10 KB |
|    AllocateArrayPool |     10 | 7,147.6 ns | 4,262.0 ns | 233.62 ns | 6,942.0 ns | 7,401.7 ns | 0.1221 | 0.1144 |     10 KB |
