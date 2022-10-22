Console.Clear();
#region y = 1

void What()
{
  const int size = 10;
  int[] array = new int[size];

  int position = 0;
  array[position] = 2022;
}

#endregion

#region y = log(n)
int BinarySearch(int[] array, int find)
{
  int left = 0;
  int right = array.Length - 1;
  while (left <= right)
  {
    int middle = (left + right) / 2;
    if (find == array[middle]) return middle;
    else if (find < array[middle]) right = middle - 1;
    else left = middle + 1;
  }
  return -1;
}
#endregion

#region y = n

int FindIndexInArray(int[] array, int find)
{
  for (int i = 0; i < array.Length; i++)
    if (array[i] == find) return i;
  return -1;
}
#endregion
