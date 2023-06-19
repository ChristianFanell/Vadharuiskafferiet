export class Fejkdash {
  reverse(str: string) {
    let output = "";
    if (str.trim() === "") return output;
    if (str === null) throw new Error();

    for (let i = str.length - 1; i >= 0; i--) {
      const char = str[i];

      output += char;
    }
    return output;
  }

  take<T>(arr: T[], to: number) {
    if (to > arr.length) return arr;
    const output: T[] = [];

    for (let i = 0; i < arr.length; i++) {
      const element = arr[i];

      if (i < to) output.push(element);
    }
    return output;
  }
}
