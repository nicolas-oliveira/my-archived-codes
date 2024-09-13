export default function handleTextRetiredFromHtml(text: string) {
  return text.replace(/[\n\r]+|[\s]{2,}/g, ' ').trim();
}