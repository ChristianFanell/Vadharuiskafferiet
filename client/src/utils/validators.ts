export const stringValidator = (
  str: string,
  func?: (s: string) => boolean
): boolean => {
  const valid = str === null || str === undefined || str?.trim().length === 0;

  return func === undefined ? valid : func(str) && valid;
};
